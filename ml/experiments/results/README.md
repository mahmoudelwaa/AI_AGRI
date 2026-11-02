# Results

Tomato model comparison on PlantVillage (color), 10 classes. Produced by `ml/notebooks/compare.ipynb` on Kaggle (Tesla T4).

- `model_comparison.csv`: test metrics, latency, size, training time per model
- `per_class_f1.csv`: F1 per class per model

Test set: 2,722 images. Split 70/15/15 stratified, seed 42. Training: 3 epochs head only, 8 epochs fine-tune.
