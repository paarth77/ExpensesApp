using ExpensesApp.Models;
using ExpensesApp.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExpensesApp.Views
{
    public partial class ExpenseDetailsPage : ContentPage
    {
        ExpenseDetailsVM ViewModel;
        public ExpenseDetailsPage()
        {
            InitializeComponent();
        }

        public ExpenseDetailsPage(Expense expense)
        {
            InitializeComponent();
            ViewModel.Expense = expense;
        }
    }
}
