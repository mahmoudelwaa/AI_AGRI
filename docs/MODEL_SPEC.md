# Model Spec

The contract between ML and Backend. ML fills the `TBD` values when the model is exported; Backend implements the preprocessing exactly as written. Any change goes through a pull request that both sides approve.

| Item | Value |
|------|-------|
| Model file | `TBD` (.onnx) |
| Architecture | `TBD` (EfficientNetB0 / MobileNetV3 / ConvNeXt-Tiny) |
| Input name and shape | `TBD`, e.g. `input` `[1, 3, 224, 224]` (NCHW, float32) |
| Resize | `TBD` (size, interpolation, keep aspect ratio or not) |
| Color order | RGB |
| Scaling | `TBD`, e.g. divide by 255 |
| Normalization | `TBD`, mean and std per channel |
| Output | `TBD`, logits or softmax probabilities, shape `[1, N]` |
| Crops covered | `TBD` |

## Class mapping

The order of classes in the model output, and the matching `Disease.id` in the database.

| Index | Class name (model) | Disease id | Crop |
|-------|--------------------|-----------|------|
| 0 | `TBD` | | |

## Validation

Before the model is handed over, ML provides 10 reference images with the expected output (top class and confidence). Backend must reproduce them within a small tolerance. This catches preprocessing mismatches early.
