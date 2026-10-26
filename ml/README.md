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

Train all three with the same split, augmentation, and number of epochs, then compare:

| Metric | MobileNetV3 | EfficientNetB0 | ConvNeXt-Tiny |
|--------|-------------|----------------|---------------|
| Accuracy | | | |
| Macro F1 | | | |
| Real-field test set accuracy | | | |
| ONNX size (MB) | | | |
| Inference time (ms) | | | |

## Phase 2: choose one

Pick on the balance of accuracy and speed, not accuracy alone. If the difference is under 1%, take the lighter model. Train it on wheat and rice.

## Rules

- Split by source (the same leaf must not appear in train and test).
- Keep a separate test set of real photos taken in the field with a phone.
- Report Macro F1 and the confusion matrix, not only accuracy.
- Export to ONNX early and check it against `docs/MODEL_SPEC.md`.
- ONNX files under about 50 MB can be committed in `models/onnx/`; larger ones go to GitHub Releases.
