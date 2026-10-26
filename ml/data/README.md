# Data

Images are **not** stored in git (see `.gitignore`). Share them through Drive / Kaggle / a release, and keep this structure so everyone uses the same paths.

| Folder | Content |
|--------|---------|
| `raw/<crop>/<class>/` | Original datasets as downloaded, one folder per class (`tomato`, `wheat`, `rice`) |
| `interim/` | Cleaned data (duplicates and bad images removed) |
| `processed/` | Final train / val / test splits (split by source so the same leaf never appears in two splits) |
| `field_test/<crop>/<class>/` | Real photos taken with a phone in the field. Used for testing only, never for training |

Write the dataset sources and licenses in a `SOURCES.md` file next to the data on the shared drive.
