# Architecture

## Diagnosis flow

1. The user selects a crop (tomato, wheat or rice), optionally a field, and takes or uploads a leaf photo in the Flutter app.
2. The app sends `POST /api/diagnoses` with the image and the crop.
3. The backend validates and stores the image, preprocesses it exactly as in training, and runs the ONNX model.
4. The backend maps class indexes to disease IDs, returns the top 3 predictions with confidence, and saves the diagnosis to the history.
5. The app shows the result and links to the Disease Information screen for the top prediction.

If the top confidence is below the threshold (initially 70%, to be tuned), the result is marked `uncertain` and the app asks for another photo.

## Components

| Component | Folder | Notes |
|-----------|--------|-------|
| Classifier | `ml/` | Trained per the plan in `ml/README.md`, exported to ONNX |
| Web API | `backend/` | ASP.NET Core, ONNX Runtime, EF Core |
| Mobile app | `mobile/` | Flutter |
| Web app | `web/` | Flutter, separate project, same API |

## Data model (draft)

```
User ──< Farm ──< Field ──< Diagnosis >── Disease
                    └── Crop
```

- **User**: id, name, email, phone (optional), password hash, created at
- **Farm**: id, user id, name, governorate, total area (feddan), location (latitude, longitude, optional). One farm per user in the MVP
- **Field**: id, farm id, name (for example "Field 4", "Greenhouse 2"), crop id, area (optional)
- **Crop**: id, name (ar / en)
- **Disease**: id, crop id, name (ar / en), description, symptoms, causes, conditions, prevention, treatment, is healthy
- **Diagnosis**: id, user id, field id (optional), crop id, image path, predicted disease id, confidence, top 3 (json), latitude and longitude (optional), created at

`Disease.id` must match the class mapping in `docs/MODEL_SPEC.md`.

## Data over the whole year

A farmer keeps diagnoses across seasons, so the data grows over time.

- The **season** is not stored: it is computed from `Diagnosis.created_at`.
- The **field health indicator** shown in the Profile screen is computed from the share of healthy diagnoses in a recent period, not stored.
- History is paged and filtered by crop, field and date range. Index `Diagnosis` on `(field id, created at)` and on `(user id, created at)`.
- Images are resized in the app before upload (about 1 MB is enough for the model). The database stores only the image path.
- Take regular backups of the database (`pg_dump`), and one before the final demo.

## Open decisions

- One model for all crops vs one model per crop (the app already asks for the crop, so the backend can pick a model or restrict classes).
- Image storage: a local folder on the machine running the backend (`backend/uploads/`) for the MVP.
- Is `fieldId` required in the MVP, or optional so a user can scan without setting up a farm first (currently optional).
- Database: PostgreSQL installed locally on each backend developer's machine, no Docker.
- Where the confidence threshold lives: backend config.
