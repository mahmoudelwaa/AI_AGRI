# Web app (Flutter)

The AgriAI website. A separate Flutter project from `mobile/`, calling the same REST API.

- Design: to be created, see [`design/web/`](../design/web/)
- API: [`docs/API_CONTRACT.md`](../docs/API_CONTRACT.md)
- Colors and typography follow [`design/DESIGN.md`](../design/DESIGN.md)
- Arabic / English with full RTL support, responsive layout

## Folder structure

```
web/
├── lib/
│   ├── core/
│   │   ├── theme/          # colors, typography, spacing from design/DESIGN.md
│   │   ├── constants/
│   │   ├── network/        # API client, auth interceptor
│   │   ├── localization/   # Arabic / English, RTL
│   │   ├── router/         # navigation
│   │   ├── utils/
│   │   └── widgets/        # shared components (buttons, cards, confidence bar, ...)
│   ├── features/           # one folder per feature, each with data/ and presentation/
│   │   ├── auth/
│   │   ├── home/
│   │   ├── scan/           # camera, crop picker, image input
│   │   ├── diagnosis/      # result screen, top 3 predictions
│   │   ├── disease_info/   # disease details, comparison and prevention
│   │   ├── history/        # past diagnoses, inspection details
│   │   └── profile/
│   └── l10n/               # translation files (arb)
├── assets/                 # images, icons, fonts
└── test/
```

## Creating the Flutter project

The folders are ready; generate the platform files inside them (run in `web/`):

```bash
flutter create . --project-name agriai_web --org com.agriai --platforms web
```

## Who owns what

Flutter 2 leads the website. Flutter 1 helps with the `scan` and `diagnosis` features, which need the file picker and camera flow on the web.

The code is separate from `mobile/`, so the API client and models are written again here. Both follow `docs/API_CONTRACT.md`.
