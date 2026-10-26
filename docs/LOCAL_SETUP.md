# Local setup

Everything runs on each team member's own machine. No Docker.

## Tools

| Role | Install |
|------|---------|
| AI | Python 3.10+, Jupyter, and the training framework |
| Backend | .NET SDK, PostgreSQL (with pgAdmin), the `dotnet-ef` tool |
| Flutter | Flutter SDK, Android Studio or a phone for testing |

## Backend

See the "Database" section in [`backend/README.md`](../backend/README.md).

## Flutter

Create the project inside the existing folder (commands are in `mobile/README.md` and `web/README.md`), then point the API base URL to the backend machine. On a phone, use the laptop's IP on the same Wi-Fi network instead of `localhost`.

## Demo day

Run the backend and PostgreSQL on one laptop, and connect the mobile app and the website to it over the same network. Take a database backup the day before.
