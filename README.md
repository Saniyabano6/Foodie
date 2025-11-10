# Foodie
A full-stack food ordering web application with separate admin and user modules. Admins can manage products and categories, while users can browse and shop for food items.
# 🍔 Your Food - Food Ordering Platform

A comprehensive ASP.NET MVC web application for food ordering with separate admin and user interfaces.

## ✨ Features

### Admin Module
- **Product Management**
  - Add, edit, and delete food products
  - Set pricing and stock levels
  - Manage product descriptions and images
  - View all products in a centralized dashboard
  
- **Category Management**
  - Create and organize food categories
  - Edit category information
  - Delete unused categories
  - Assign products to categories

- **Dashboard & Analytics**
  - View total products and categories
  - Monitor inventory levels
  - Track system statistics

### User Module
- Browse food products by categories
- View detailed product information with images
- Add items to shopping cart
- Update cart quantities
- View order summary and total price
- User-friendly interface with responsive design

## 🛠️ Technologies Used
- **Backend:** ASP.NET MVC (.NET Framework/Core)
- **Frontend:** HTML5, CSS3, Bootstrap
- **Database:** SQL Server / Entity Framework
- **ORM:** Entity Framework
- **Authentication:** ASP.NET Identity
- **Architecture:** MVC (Model-View-Controller)

## 📁 Project Structure
```
YourFood/
├── Controllers/
│   ├── AdminController.cs
│   ├── ProductController.cs
│   ├── CategoryController.cs
│   └── UserController.cs
├── Models/
│   ├── Product.cs
│   ├── Category.cs
│   ├── Cart.cs
│   └── User.cs
├── Views/
│   ├── Admin/
│   ├── Product/
│   ├── Category/
│   └── Shared/
├── Data/
│   └── ApplicationDbContext.cs
└── wwwroot/
    ├── css/
    ├── js/
    └── images/
```

