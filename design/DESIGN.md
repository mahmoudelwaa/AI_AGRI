---
name: AgriAI
colors:
  surface: '#f9f9ff'
  surface-dim: '#d3daea'
  surface-bright: '#f9f9ff'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f0f3ff'
  surface-container: '#e7eefe'
  surface-container-high: '#e2e8f8'
  surface-container-highest: '#dce2f3'
  on-surface: '#151c27'
  on-surface-variant: '#404943'
  inverse-surface: '#2a313d'
  inverse-on-surface: '#ebf1ff'
  outline: '#707973'
  outline-variant: '#bfc9c1'
  surface-tint: '#2b694f'
  primary: '#003523'
  on-primary: '#ffffff'
  primary-container: '#064e36'
  on-primary-container: '#7fbe9f'
  inverse-primary: '#94d4b4'
  secondary: '#006c4a'
  on-secondary: '#ffffff'
  secondary-container: '#96f6c7'
  on-secondary-container: '#00734f'
  tertiary: '#2d2e2a'
  on-tertiary: '#ffffff'
  tertiary-container: '#444440'
  on-tertiary-container: '#b2b1ac'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#b0f0cf'
  primary-fixed-dim: '#94d4b4'
  on-primary-fixed: '#002114'
  on-primary-fixed-variant: '#0b5139'
  secondary-fixed: '#96f6c7'
  secondary-fixed-dim: '#7ad9ac'
  on-secondary-fixed: '#002114'
  on-secondary-fixed-variant: '#005237'
  tertiary-fixed: '#e4e2dd'
  tertiary-fixed-dim: '#c8c6c1'
  on-tertiary-fixed: '#1b1c18'
  on-tertiary-fixed-variant: '#474743'
  background: '#f9f9ff'
  on-background: '#151c27'
  surface-variant: '#dce2f3'
typography:
  display-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 34px
    fontWeight: '700'
    lineHeight: 41px
    letterSpacing: -0.02em
  headline-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 28px
    fontWeight: '700'
    lineHeight: 34px
    letterSpacing: -0.015em
  headline-lg-mobile:
    fontFamily: Plus Jakarta Sans
    fontSize: 24px
    fontWeight: '700'
    lineHeight: 30px
  headline-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 25px
    letterSpacing: -0.01em
  body-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 17px
    fontWeight: '400'
    lineHeight: 22px
  body-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 15px
    fontWeight: '400'
    lineHeight: 20px
  body-sm:
    fontFamily: Plus Jakarta Sans
    fontSize: 13px
    fontWeight: '400'
    lineHeight: 18px
  label-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 12px
    fontWeight: '600'
    lineHeight: 16px
    letterSpacing: 0.04em
  label-sm:
    fontFamily: Plus Jakarta Sans
    fontSize: 11px
    fontWeight: '500'
    lineHeight: 14px
    letterSpacing: 0.02em
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  gutter: 1rem
  margin: 1.25rem
  space-xs: 0.25rem
  space-sm: 0.5rem
  space-md: 1rem
  space-lg: 1.5rem
  space-xl: 2rem
---

## Brand & Style

The design system embodies agricultural intelligence—clinical, precise diagnostics balanced by organic vitality and earthy assurance. Designed for field agronomists, commercial farm managers, and rural smallholders across bilingual regions (with native Arabic and English parity), the UI balances utility in harsh outdoor sunlight with modern, high-end iOS mobile sophistication.

The aesthetic fuses **Modern iOS Human Interface** principles with **Clean Organic Precision**. It avoids agricultural clichés like mud-browns and novelty leaf motifs; instead, it relies on crystalline layouts, deep canopy emeralds, high-contrast status cues, and soft, tactile card groupings that feel authoritative, scientifically vetted, and immediate.

## Colors

The palette grounds high-tech computer vision in deep biological tones:

- **Primary (`#064E36` - Forest Canopy):** Anchors headers, primary brand touchpoints, critical diagnostics, and key action backdrops. Provides strong contrast against outdoor glares.
- **Secondary (`#087B55` - Agricultural Growth):** Interactive states, prominent primary buttons, verified health statuses, and positive diagnostics.
- **Tertiary / Canvas Accent (`#F8F6F0` - Warm Alabaster):** Replaces sterile grays with an organic, subtle warmth for secondary card surfaces and ambient container fills.
- **Surface & Base (`#FFFFFF` - Crisp White & `#EAF6F0` - Pale Mint):** Pale mint functions as a contextual tint for healthy crop tags, active tab indicators, and highlighted diagnostic areas.
- **Neutral Core (`#111827` Text, `#6B7280` Muted Gray, `#E5E7EB` Dividers):** High-legibility neutral system delivering WCAG AAA-compliant body copy and subtle interface dividers.
- **Diagnostic Alerts:** Amber (`#D97706`) for stress warnings; Crimson (`#DC2626`) for virulent pathogens.

## Typography

The typographic hierarchy prioritizes rapid scanability in mobile conditions. 

- **Primary Typeface:** **Plus Jakarta Sans** is the Latin primary font, chosen for wide aperture characters, clean geometric terminals, and excellent legibility across small status badges and metadata screens.
- **Bilingual Arabic Pairing:** Cairo or Tajawal serves as the primary Arabic partner font across RTL contexts, dynamically matched to Plus Jakarta Sans' weights (Regular 400, SemiBold 600, Bold 700). Cairo’s baseline stability matches iOS HIG standards for dynamic type sizes.
- **RTL Behavior:** Letter-spacing tokens are set to `0` for all Arabic glyphs to preserve natural cursive connections, and numerical telemetry retains tabular lining figures (`font-variant-numeric: tabular-nums`).

## Layout & Spacing

Built strictly around an 8-point spatial grid optimized for high-density mobile displays (375pt to 430pt viewports):

- **Margins & Safe Zones:** Canvas margins default to `1.25rem` (20px), accommodating iOS home indicators, dynamic islands, and edge-swipe gestures. In-card padding is pinned to `1rem` (16px) for compact efficiency.
- **Column Mechanics:** Native single-column fluid card layout on mobile; reflows into a 2-column or split inspection dashboard (4-column grid, 16px gutter) on iPad/tablet field devices.
- **Touch Targets:** All interactive triggers maintain an absolute minimum touch boundary of 44×44pt, expanding to 56pt height for primary diagnosis and capture triggers.

## Elevation & Depth

Visual hierarchy uses clean atmospheric layering rather than sharp contrast edges, retaining an airy, native iOS feel:

- **Level 0 (Canvas Base):** `#F8F6F0` (Warm Cream tint) or pure `#FFFFFF` background.
- **Level 1 (Surface Cards & Panels):** Solid `#FFFFFF` elevated with ambient, diffused shadows: `0px 4px 20px -2px rgba(6, 78, 54, 0.05), 0px 2px 6px -1px rgba(0, 0, 0, 0.04)`. The faint emerald undertone keeps white cards visually anchored to the brand.
- **Level 2 (Diagnostic Floating Modals & Sheet Layers):** Elevated with `0px 12px 32px -4px rgba(6, 78, 54, 0.12)`.
- **Level 3 (Action Triggers & Bottom App Bar):** Floating persistent elements apply a soft white/translucent frosted backdrop blur (`backdrop-filter: blur(20px) saturate(180%)`) with an ultra-thin 0.5px border (`rgba(6, 78, 54, 0.08)`).

## Shapes

The design system enforces an Apple-style continuous squircle language (`roundedness: 2`):

- **Cards & Primary Modules:** Standardized at `rounded-lg` (16px / 1rem) for an approachable, modern feel.
- **Inputs, Filter Badges, & Chips:** Styled with 8px–12px rounding, matching internal sub-elements.
- **Camera Action Hub & Pills:** Full-pill treatment (`rounded-full`) reserved exclusively for the central Floating Action Button (FAB), scan buttons, and real-time status chips.

## Components

- **Floating Camera Action Button (FAB):** A 64×64pt circular pill located in the center of the bottom navigation bar. Wrapped in a `#087B55` to `#064E36` linear gradient with an exterior 4px ring of `#FFFFFF` and elevated ambient glow. Displays an optical aperture or scanning leaf icon.
- **Bottom Navigation Bar:** Frosted glass bar (height: 64pt + safe area) housing four icon+label destinations (Fields, Scans, Library, Profile) centered around the raised camera trigger notch.
- **Diagnostic Result Cards:** Segmented cards sporting confidence percentage gauges, pathogen taxonomy, severity status tags (e.g., "Early Blight - 98% Match"), and instant biological treatment toggles.
- **Badges & Chips:** Compact height (28pt) badges in `#EAF6F0` fill with `#064E36` text for healthy statuses, switching to warning hues for active infections. Micro dot indicators (6px) anchor the leading edge.
- **Input & Search Fields:** Embedded within `#FFFFFF` surfaces with a 1px border (`#E5E7EB`), transitioning to a 2px `#087B55` border on focus; includes inline clear targets and RTL-mirrored search glyphs.
- **Crop Health Sliders & Metric Gauges:** High-contrast progress indicators with forest green tracks and pale mint reservoirs, delivering glanceable field data under direct daylight.