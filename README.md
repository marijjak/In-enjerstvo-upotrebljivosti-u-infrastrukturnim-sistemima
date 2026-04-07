

**Chanel CMS** is a high-end desktop Content Management System developed as part of the "Inženjerstvo upotrebljivosti u infrastrukturnim sistemima" course. The application is designed to manage and showcase the most significant historical moments of the House of Chanel, from the opening of the first boutique to modern-day runway spectacles.

## 📸 Preview
Custom-designed interface featuring a minimalist luxury aesthetic with gold accents and a signature Coco Chanel watermark.*

## ✨ Features

### 👤 User Roles & Access Control
- **Admin:** Full control over content.Capability to add, edit, and delete moments.
- **Visitor:** Read-only access to browse the history and view detailed information.
- All user data and sessions are securely handled via **XML serialization**.

### 📝 Advanced Content Management
- **Table View:** Integrated `DataGrid` with custom templates for images, hyperlinks, and multi-selection via CheckBoxes.
- **Rich Text Editor:** A fully-featured text editor for descriptions, supporting:
  - Bold, Italic, Underline.
  - Font family preview and size adjustment.
  - Custom color picker with all system colors.
  - Real-time word count in the status bar.
-**Automated Logging:** Each entry automatically records the timestamp of its creation.

### 🎨 Design & Usability
- **Thematic Consistency:** A dark, elegant "Lux" theme using a palette of Gold (#BFA181) and Charcoal (#1a1a1a).
- **Validation:** Robust input validation for all fields (including RichTextBox) with clear, field-specific error messages.
- **Interactive UX:** Responsive cursors, detailed ToolTips, and confirmation dialogs for critical actions (like deletion).

## 🛠️ Technical Stack
- **Framework:** .NET / WPF (Windows Presentation Foundation)
- **Language:** C# (Clean Code & naming conventions)
- **Data Storage:** - `*.xml` for object data and user accounts.
  - *.rtf` for styled textual content.
- **Architecture:** MVVM-inspired structure with custom Converters and relative paths for portability.

## 🚀 Getting Started
1. Clone the repository.
2. Open the `.sln` file in Visual Studio.
3. Ensure all image resources in `/Resources/` are set to `Build Action: Resource`.
4. Build and Run.

**Login Credentials:**
- *Admin:* `admin` / `admin123`
- *Visitor:* `visitor` / `visitor123`

---
Developed for the **Applied Software Engineering** department at FTN.
