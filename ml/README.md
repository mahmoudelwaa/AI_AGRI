# ML

Image classification of crop leaf diseases for tomato, wheat and rice.

## Folder structure

```
ml/
├── configs/        # one config per experiment (model, image size, lr, epochs, seed)
├── data/           # raw, interim, processed, field_test (images are not in git, see data/README.md)
├── notebooks/      # exploration: EDA, quick experiments
├── src/
│   ├── data/       # loading, cleaning, splitting, augmentation
│   ├── models/     # model definitions (MobileNetV3, EfficientNetB0, ConvNeXt-Tiny)
│   ├── training/   # training loop
│   ├── evaluation/ # metrics, confusion matrix, field-test evaluation
│   ├── export/     # ONNX export and the 10 reference images check
│   └── inference/  # prediction helper that matches docs/MODEL_SPEC.md
├── models/
│   ├── checkpoints/ # training weights (not in git)
│   └── onnx/        # exported models handed to the backend
├── experiments/results/ # metrics tables per run, comparison results
├── reports/figures/     # confusion matrices, Grad-CAM, charts for the documentation
└── tests/
```

## Roles

| Who | Works in |
|-----|----------|
| AI 1 (lead) | `src/models`, `src/training`, `src/evaluation`, `experiments/` |
| AI 2 | `data/`, `src/data`, field test set, training for the remaining crops |
| Both | `src/export`, `models/onnx`, `docs/MODEL_SPEC.md` |

## Candidate models

| Model | Why |
|-------|-----|
| MobileNetV3 | Smallest and fastest, designed for mobile |
| EfficientNetB0 | Balanced, stable transfer learning |
| ConvNeXt-Tiny | Likely the highest accuracy, but heavier |

## Phase 1: comparison on tomato

Same split (70/15/15, stratified, seed 42), augmentation and epochs (3 head + 8 fine-tune) for all models. Dataset: PlantVillage color, 10 tomato classes, 18,146 images after removing 14 exact duplicates. Test set: 2,722 images. Full code: [`notebooks/compare.ipynb`](notebooks/compare.ipynb), numbers: [`experiments/results/`](experiments/results/).

| Metric | MobileNetV3-Large | EfficientNet-B0 | ResNet50 |
|--------|-------------------|-----------------|----------|
| Accuracy | 0.9934 | 0.9934 | 0.9956 |
| Macro F1 | 0.9916 | 0.9928 | 0.9954 |
| Real-field test set accuracy | pending | pending | pending |
| ONNX size (MB) | ~17 | ~16 | ~94 |
| CPU inference time (ms, batch 1) | 18.5 | 33.8 | 129.4 |

Notes:
- ConvNeXt-Tiny was replaced by ResNet50 as the heavier baseline. Add ConvNeXt-Tiny later if needed.
- PlantVillage images are lab photos on plain backgrounds and the split is random, so these numbers are optimistic. The real-field test set is the number that matters.
- Size column is the PyTorch checkpoint size from the notebook; the ResNet50 ONNX is 94.0 MB (above the 50 MB limit, so it goes to GitHub Releases if needed).

## Phase 2: choose one

Pick on the balance of accuracy and speed, not accuracy alone. If the difference is under 1%, take the lighter model. Train it on wheat and rice.

## Rules

- Split by source (the same leaf must not appear in train and test).
- Keep a separate test set of real photos taken in the field with a phone.
- Report Macro F1 and the confusion matrix, not only accuracy.
- Export to ONNX early and check it against `docs/MODEL_SPEC.md`.
- ONNX files under about 50 MB can be committed in `models/onnx/`; larger ones go to GitHub Releases.
