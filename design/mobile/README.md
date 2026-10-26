# Mobile design

Google Stitch screens for the mobile app, in `screens/` (PNG for reference, HTML exported from Stitch).
The HTML files load some images from Stitch URLs that may expire, so use the PNGs as the reference.
The shared design system is in [`../DESIGN.md`](../DESIGN.md).

## Parts of the design that are not in the MVP

The Profile and Inspection screens show a few things the app will not build:

- Agricultural weather alerts (weather forecasting is out of scope)
- "AI Inspection Cam 4K" and "multispectral sensor" labels (decoration from Stitch)
- Gold membership, request an expert call, share a PDF report (possible later)

Remove or hide them when building the Flutter screens.
