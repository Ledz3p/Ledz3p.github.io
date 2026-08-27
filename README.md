# 🧶 Yarn Inventory Tracker

A fast, responsive Progressive Web Application (PWA) designed for tracking yarn stock, active project bags, and discontinued products across desktop and mobile devices. 

Built with **Blazor WebAssembly** and hosted on **GitHub Pages**, featuring cloud sync via private GitHub Personal Access Tokens.

🚀 **Live App:** https://ledz3p.github.io

---

## ✨ Features

- **📱 Offline-First PWA:** Install directly to your iOS or Android home screen for a native app feel.
- **☁️ Private Cloud Sync:** Syncs inventory changes seamlessly across devices using GitHub's REST API.
- **🏷️ Active & Discontinued Tabs:** Easily categorize and transition items between active inventory and archived stock.
- **🔍 Smart Search & Alphabetical Sorting:** Instantly filter by brand, color code, or description. Items are automatically sorted by color name, ignoring numeric prefixes.
- **✏️ On-the-Go Management:**
  - **Manual Entry:** Add custom yarn products directly from your phone.
  - **Inline Editing:** Fix typos or update brand names on the fly.
  - **Permanent Delete:** Remove unwanted entries with safety confirmation guards.
- **⏪ Undo / Redo Engine:** Step backward or forward through recent inventory adjustments.
- **📊 Spreadsheet Import:** Bulk import existing inventory records from `.xlsx` files.

---

## 🛠️ Tech Stack

- **Framework:** Blazor WebAssembly (.NET 8.0)
- **Styling:** Custom CSS (Mobile-first responsive design)
- **Storage:** Browser `localStorage` + Remote `inventory.json` via GitHub API
- **CI/CD & Hosting:** GitHub Actions & GitHub Pages

---

## 🚀 Local Development Setup

To run this project locally on your development machine:

### Prerequisites
- .NET 8.0 SDK (https://dotnet.microsoft.com/download/dotnet/8.0)

### Steps
1. **Clone the repository:**
   git clone https://github.com/Ledz3p/ledz3p.github.io.git
   cd ledz3p.github.io

2. **Build and Run:**
   dotnet watch

3. Open your browser and navigate to `http://localhost:5000` (or the port specified in terminal output).

---

## 🔑 Initial Cloud Setup

1. Open the live app or local instance.
2. Generate a GitHub Personal Access Token (Classic) with `repo` permissions.
3. Click **🔑 Link Cloud** in the app header and paste your token.
4. Tap **Save & Initialize Cloud** to begin syncing changes.

---

## 📄 License

This project is open-source and available under the MIT License.
