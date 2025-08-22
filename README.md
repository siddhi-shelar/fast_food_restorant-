# fast_food_restorant-
Fast Food Billing System (.NET)
📌 Project Overview

This project is a .NET Windows Forms Application designed to automate the billing system of a fast food restaurant. It allows users to select menu items, enter quantities, calculate totals, apply taxes, and print receipts.

The system simplifies the order and billing process by generating customer-friendly receipts and maintaining accuracy in calculations.

📂 Features

✅ Menu Selection – Customers can choose from available fast food items (e.g., burgers, fries, pizza, drinks).

✅ Quantity Input – Enter the number of items ordered.

✅ Automatic Calculation – Subtotal, tax, and final total are calculated automatically.

✅ Receipt Generation – Displays a formatted bill in a RichTextBox.

✅ Print Functionality – Print the receipt directly from the application.

✅ Reset Functionality – Clear all fields and start a new order.

🛠 Tech Stack

C# (.NET Framework / Windows Forms)

Visual Studio IDE

System.Drawing & Printing Libraries (for printing receipt)

📖 How It Works

Select food items using checkboxes.

Enter the quantity in textboxes.

Click Calculate → The system computes:

Subtotal

Tax (e.g., 5% or 10%)

Final Total

The receipt is displayed in the RichTextBox.

Click Print to print the customer’s bill.

Click Reset to clear selections and prepare for the next order.

📌 Example Receipt Output
       FastFood Billing System
---------------------------------
Item            Qty    Price
Burger          2      200
Fries           1       80
Coke            2      100
---------------------------------
Subtotal:              380
Tax (5%):              19
---------------------------------
Total:                 399
---------------------------------
Thank You! Visit Again!

🚀 Future Enhancements

Add database integration (SQL Server) to track sales history.

Implement user login system for cashier/staff management.

Add discounts & coupons functionality.

Generate PDF bills along with printed receipts.

Dashboard view for daily/weekly sales analytics.
