# Mobile app (Flutter)

The AgriAI mobile app for Android and iOS.

- Design: [`design/mobile/`](../design/mobile/) and the shared design system [`design/DESIGN.md`](../design/DESIGN.md)
- API: [`docs/API_CONTRACT.md`](../docs/API_CONTRACT.md)
- Arabic / English with full RTL support

## Folder structure

```
mobile/
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
│   │   ├── farm/           # farm info and fields
│   │   └── profile/
│   └── l10n/               # translation files (arb)
├── assets/                 # images, icons, fonts
└── test/
```

Every feature has `data/` (API calls, models, repository) and `presentation/` (screens, widgets, state).

## Creating the Flutter project

The folders are ready; generate the platform files inside them (run in `mobile/`):

```bash
flutter create . --project-name agriai_mobile --org com.agriai --platforms android,ios
```

## Who owns what

| Role | Features |
|------|----------|
| Flutter 1 | `home`, `scan`, `diagnosis`, camera |
| Flutter 2 | `disease_info`, `history`, `farm`, `profile`, `auth` |
| Both | `core/` (theme, network, shared widgets) |

Screens from the design: home, scan, diagnosis result, disease information, comparison and prevention, diagnosis history, inspection details, profile.
