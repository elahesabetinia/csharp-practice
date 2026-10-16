BankAccount account = new BankAccount("Sara", 100);

account.ShowBalance();          // 100
account.Deposit(50);
account.ShowBalance();          // 150
account.Withdraw(200);          // موجودی کافی نیست
account.Withdraw(70);
account.ShowBalance();          // 80
account.Deposit(-5);            // نامعتبر