# WeNeed1 – Quick Start

## 🖥️ Backend (API + DB)

Inside **WeNeed1**, run:

```
docker-compose up --build
```

- Runs API and SQL Server & seeds test data automatically

---

## 🖥️ Admin App

Inside `WeNeed1/DesktopUI/managerdesktop/`, run:

```
flutter run -d windows
```

**Login:**  
**Username:** `fatih`  
**Password:** `12345678`

---

## 📱 Mobile App

Inside `WeNeed1/MobileUI/playermobile`, run:

```
flutter run \
  --dart-define=API_HOST=10.0.2.2 \
  --dart-define=API_PORT=5000 \
  --dart-define=STRIPE_PUBLIC_KEY=pk_test_51RZspNPxAmoaM21xXeLBdVCpKN8CcQpf1QSGUJ4nbQla9GNAJQSJHrfHov0xhBzzf9OMjvM8Fyb6VB6EowJqO1bM00ong8kgTF
```

**Login:**  
**Username:** `haris`  
**Password:** `12345678`

---

## 💳 Stripe Test Card

- **Card:** `4242 4242 4242 4242`  
- **Exp:** `04/34`  
- **CVC:** `123`  
- **ZIP:** any (e.g. `10000`)
