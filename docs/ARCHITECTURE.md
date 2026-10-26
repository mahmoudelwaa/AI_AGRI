# Architecture

## Diagnosis flow

1. The user selects a crop (tomato, wheat or rice) and takes or uploads a leaf photo in the Flutter app.
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

- **User**: id, name, email, password hash, created at
- **Crop**: id, name (ar / en)
- **Disease**: id, crop id, name (ar / en), description, symptoms, causes, prevention, treatment, is healthy
- **Diagnosis**: id, user id, crop id, image path, predicted disease id, confidence, top 3 (json), created at

`Disease.id` must match the class mapping in `docs/MODEL_SPEC.md`.

## Open decisions

- One model for all crops vs one model per crop (the app already asks for the crop, so the backend can pick a model or restrict classes).
- Image storage: local volume vs cloud storage.
- Where the confidence threshold lives: backend config.
