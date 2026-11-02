# Data

Images are **not** stored in git (see `.gitignore`). Share them through Drive / Kaggle / a release, and keep this structure so everyone uses the same paths.

| Folder | Content |
|--------|---------|
| `raw/<crop>/<class>/` | Original datasets as downloaded, one folder per class (`tomato`, `wheat`, `rice`) |
| `interim/` | Cleaned data (duplicates and bad images removed) |
| `processed/` | Final train / val / test splits (split by source so the same leaf never appears in two splits) |
| `field_test/<crop>/<class>/` | Real photos taken with a phone in the field. Used for testing only, never for training |

Write the dataset sources and licenses in a `SOURCES.md` file next to the data on the shared drive.

## Datasets used so far

### Tomato: PlantVillage (color)

| Item | Value |
|------|-------|
| Source | Kaggle: `abdallahalidev/plantvillage-dataset`, folder `color` |
| Classes | 10 tomato classes (folders starting with `Tomato___`) |
| Images found | 18,160 |
| Unreadable files | 0 |
| Exact duplicates removed (MD5) | 14 (no label conflicts) |
| Images used | 18,146 |
| Largest / smallest class | 14.4x (Yellow Leaf Curl Virus vs Mosaic virus) |

| Class | Images | Share |
|-------|--------|-------|
| Bacterial_spot | 2127 | 11.7% |
| Early_blight | 1000 | 5.5% |
| Late_blight | 1901 | 10.5% |
| Leaf_Mold | 952 | 5.2% |
| Septoria_leaf_spot | 1771 | 9.8% |
| Spider_mites Two-spotted_spider_mite | 1676 | 9.2% |
| Target_Spot | 1404 | 7.7% |
| Tomato_Yellow_Leaf_Curl_Virus | 5357 | 29.5% |
| Tomato_mosaic_virus | 373 | 2.1% |
| healthy | 1585 | 8.7% |

Counts are in [`tomato_class_counts.csv`](tomato_class_counts.csv). The imbalance is handled with class weights in the loss (Mosaic virus weight 4.87, Yellow Leaf Curl 0.34).

### Split used in the comparison

Stratified 70 / 15 / 15 with seed 42: train 12,702, val 2,722, test 2,722 (see `notebooks/compare.ipynb`).

Known limits:
- The split is random per image. PlantVillage has several photos of the same leaf, so near-identical images can fall in both train and test and inflate the scores. The rule above (split by source) is not met yet; PlantVillage has no source id, so this needs a grouping step or a field test set.
- PlantVillage photos are lab shots on plain backgrounds. Real phone photos in the field will score lower.
- The `train.csv`, `val.csv`, `test.csv` files written by the notebook contain Kaggle paths. Keep them with the data on the shared drive, not in git.

### Still to collect
- Real-field tomato photos for `field_test/tomato/`
- Wheat and rice datasets (`raw/wheat`, `raw/rice`)
- Tomato classes that the database has and PlantVillage does not (Fusarium Wilt), or remove it from the database (see `docs/MODEL_SPEC.md`)

Write the licence of each dataset in `SOURCES.md` on the shared drive (check the licence on the Kaggle page before the final report).
