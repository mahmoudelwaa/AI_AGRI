# Model Spec

The contract between ML and Backend. ML fills the `TBD` values when the model is exported; Backend implements the preprocessing exactly as written. Any change goes through a pull request that both sides approve.

Status: preprocessing and class order are fixed (tomato, 10 classes). The final architecture and `.onnx` file are still pending selection (see `ml/README.md`, Phase 1).

| Item | Value |
|------|-------|
| Model file | `TBD` (.onnx) |
| Architecture | `TBD` (candidates: EfficientNet-B0 / MobileNetV3-Large; ResNet50 as baseline) |
| Input name and shape | `input`, `[N, 3, 224, 224]` (NCHW, float32), dynamic batch axis |
| Resize | Direct resize to 224x224 (no crop, aspect ratio not kept), bilinear (torchvision default) |
| Color order | RGB |
| Scaling | Divide by 255 (range 0 to 1) |
| Normalization | mean `[0.485, 0.456, 0.406]`, std `[0.229, 0.224, 0.225]` per channel (ImageNet) |
| Output | Logits (no softmax), name `logits`, shape `[N, 10]`. Backend applies softmax. |
| Crops covered | Tomato |

## Class mapping

The order of classes in the model output (same as `ml/models/onnx/labels.json`, alphabetical), and the matching `Disease.id` in the database (`DiseaseSeed.cs`).

| Index | Class name (model) | Disease id | Crop |
|-------|--------------------|-----------|------|
| 0 | `Tomato___Bacterial_spot` | 105 | Tomato |
| 1 | `Tomato___Early_blight` | 102 | Tomato |
| 2 | `Tomato___Late_blight` | 103 | Tomato |
| 3 | `Tomato___Leaf_Mold` | not in DB yet | Tomato |
| 4 | `Tomato___Septoria_leaf_spot` | 104 | Tomato |
| 5 | `Tomato___Spider_mites Two-spotted_spider_mite` | not in DB yet | Tomato |
| 6 | `Tomato___Target_Spot` | not in DB yet | Tomato |
| 7 | `Tomato___Tomato_Yellow_Leaf_Curl_Virus` | 107 | Tomato |
| 8 | `Tomato___Tomato_mosaic_virus` | not in DB yet | Tomato |
| 9 | `Tomato___healthy` | 101 | Tomato |

Open mismatch between model and database: the seed has `Fusarium Wilt` (106), which the model cannot predict (not in PlantVillage), and has no entries for Leaf Mold, Spider mites, Target Spot and Mosaic virus. Either add those four diseases to the seed or drop those classes from the model.

## Validation

Before the model is handed over, ML provides 10 reference images with the expected output (top class and confidence). Backend must reproduce them within a small tolerance. This catches preprocessing mismatches early.

The ONNX export was checked against PyTorch on a random input: max absolute difference 2.9e-06 (opset 17).
