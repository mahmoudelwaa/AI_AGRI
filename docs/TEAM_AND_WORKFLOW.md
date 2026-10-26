# Team and Workflow

## Roles

| Role | Members | Responsibilities |
|------|---------|------------------|
| **AI 1** (lead) | | Model experiments and selection, evaluation, review of all pull requests |
| **AI 2** | | Data cleaning and splits, training for the remaining crops, real-field test set |
| **Backend 1** | | Authentication, users, database schema and migrations |
| **Backend 2** | | Disease information and diagnosis history APIs, Swagger docs |
| **Backend 3** | | ONNX Runtime integration, image processing, upload endpoint, Docker and deployment |
| **Flutter 1** | | Mobile app: camera, scan and result screens |
| **Flutter 2** | | Disease info, history, profile, auth screens in the mobile app, and the website (`web/`) with its responsive layout |

Shared: AI 1 and AI 2 export ONNX together; Flutter 1 and 2 follow the same API contract and design system (`design/DESIGN.md`) across `mobile/` and `web/`.

## Agreements to make in the first days

1. **API contract** (`docs/API_CONTRACT.md`): fixed before Flutter and Backend write code. Flutter works on mock data until the API is ready.
2. **Model spec** (`docs/MODEL_SPEC.md`): AI and Backend 3 agree on input size, normalization and class order.
3. **Class to disease mapping**: model class names match disease IDs in the database.

Backend 3 integrates a placeholder model in the first week so the whole pipeline runs end to end early; the final model is swapped in later.

## Git workflow

- `main` is protected: no direct pushes, every change goes through a pull request.
- Branch names: `ml/<topic>`, `backend/<topic>`, `mobile/<topic>`, `web/<topic>`, `docs/<topic>`.
- Each pull request needs one review from the repository owner and, when it crosses areas (for example API shape), one from the other side.
- Commit messages in English, short and imperative: `Add diagnosis history endpoint`.
- No datasets, model weights or secrets in git (see `.gitignore`).

## Milestones

| Phase | Goal |
|-------|------|
| 1. Setup | Repo, contracts, database schema, model experiments on tomato |
| 2. First demo | Tomato diagnosis end to end: app, API, ONNX, result |
| 3. Expansion | Wheat and rice, full Disease Information and History |
| 4. Hardening | Real-field testing, confidence threshold, Grad-CAM (optional), website |
| 5. Delivery | Documentation, deployment, defense preparation |
