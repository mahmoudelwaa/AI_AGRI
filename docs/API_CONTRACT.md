# API Contract (draft)

Base path: `/api`. JSON everywhere except image upload (`multipart/form-data`). Auth uses a JWT bearer token. This file is the source of truth until Swagger is generated from the code; change it by pull request.

## Auth

| Method | Path | Body | Response |
|--------|------|------|----------|
| POST | `/auth/register` | `name, email, password` | `token, user` |
| POST | `/auth/login` | `email, password` | `token, user` |
| GET | `/users/me` | | `user` |
| PUT | `/users/me` | `name, phone` | `user` |

## Farm and fields

| Method | Path | Body | Response |
|--------|------|------|----------|
| GET | `/farm` | | The current user's farm |
| PUT | `/farm` | `name, governorate, totalArea, latitude, longitude` | `farm` |
| GET | `/fields` | | Fields of the farm |
| POST | `/fields` | `name, cropId, area` | `field` |
| PUT | `/fields/{id}` | `name, cropId, area` | `field` |
| DELETE | `/fields/{id}` | | Removes the field (its diagnoses stay in the history) |

## Diagnosis

| Method | Path | Notes |
|--------|------|-------|
| POST | `/diagnoses` | multipart: `image`, `cropId`, optional `fieldId`, `latitude`, `longitude`. Runs the model and saves the result |
| GET | `/diagnoses` | Current user's history, newest first. Query: `cropId`, `fieldId`, `from`, `to`, `page`, `pageSize` |
| GET | `/diagnoses/{id}` | One diagnosis |
| DELETE | `/diagnoses/{id}` | Remove from history |

`POST /diagnoses` response:

```json
{
  "id": "…",
  "cropId": 1,
  "fieldId": 4,
  "status": "ok",
  "predictions": [
    { "diseaseId": 4, "name": "Early Blight", "confidence": 0.93 },
    { "diseaseId": 7, "name": "Late Blight", "confidence": 0.04 },
    { "diseaseId": 1, "name": "Healthy", "confidence": 0.01 }
  ],
  "imageUrl": "…",
  "createdAt": "…"
}
```

`status` is `ok` or `uncertain` (top confidence below the threshold).

## Diseases

| Method | Path | Notes |
|--------|------|-------|
| GET | `/crops` | Crops list |
| GET | `/diseases?cropId=` | Diseases for a crop |
| GET | `/diseases/{id}` | Symptoms, causes, prevention, treatment, look-alikes |

Names and texts are returned in both languages (`name.ar`, `name.en`), or by an `Accept-Language` header, to be decided with the Flutter team.

## Later (after the MVP)

- `GET /fields/{id}/summary`: health indicator and disease counts for a field over a period.
