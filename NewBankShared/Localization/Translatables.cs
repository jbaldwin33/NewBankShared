﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewBankShared.Localization
{
  public class WelcomeTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Welcome to J Bank";
  }

  public class DepositTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "deposit";
  }

  public class DepositCommandTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Deposit";
  }

  public class WithdrawTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "withdraw";
  }

  public class WithdrawCommandTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Withdraw";
  }

  public class TransferTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "transfer";
  }

  public class TransferCommandTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Transfer";
  }

  public class OperationQuestionTranslatable : Translatable
  {
    public OperationQuestionTranslatable(string operation) : base(operation) { }
    protected override string GetDefaultTransalationBasisText() => "How much would you like to {0}?";
  }

  public class FailedToGetAccountDetailsErrorTranslatable : Translatable
  {
    public FailedToGetAccountDetailsErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Failed to get account details: {0}";
  }

  public class ErrorTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Error";
  }

  public class InformationTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Information";
  }

  public class AmountGreaterThanZeroTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter an amount greater than 0";
  }

  public class OperationFailedErrorTranslatable : Translatable
  {
    public OperationFailedErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Operation failed: {0}";
  }

  public class EnterUserForTransferTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter a user to transfer funds to";
  }

  public class TransferFailedErrorTranslatable : Translatable
  {
    public TransferFailedErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Transfer failed : {0}";
  }

  public class UsernameDoesNotExistTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "This username does not exist";
  }

  public class LoginSuccessfulTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Log in successful";
  }

  public class LoginFailedErrorTranslatable : Translatable
  {
    public LoginFailedErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Log in failed: {0}";
  }

  public class LogoutSuccessfulTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Log out successful";
  }

  public class LogoutFailedErrorTranslatable : Translatable
  {
    public LogoutFailedErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Log out failed: {0}";
  }

  public class SignUpSuccessfulTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Sign up successful";
  }

  public class SignUpFailedErrorTranslatable : Translatable
  {
    public SignUpFailedErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Sign up failed: {0}";
  }

  public class CheckingLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Checking";
  }

  public class SavingLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Saving";
  }

  public class UsernameAlreadyExistsTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "This username already exists";
  }

  public class FailedToGetTransactionsErrorTranslatable : Translatable
  {
    public FailedToGetTransactionsErrorTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "Failed to get transactions: {0}";
  }

  public class LoginLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Log in";
  }

  public class LogoutLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Log out";
  }

  public class SignUpLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Sign up";
  }

  public class UsernameLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Username";
  }

  public class PasswordLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Password";
  }

  public class FirstNameLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "First name";
  }

  public class LastNameLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Last name";
  }

  public class AccountTypeLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Account type";
  }

  public class BalanceLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Balance";
  }

  public class RecentTransactionsLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Recent transactions";
  }

  public class HomeLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Home";
  }

  public class AccountLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Account";
  }

  public class UserDetailsLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "User details";
  }

  public class TransactionsLabelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Transactions";
  }

  public class ConfirmTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Confirm";
  }

  public class CancelTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Cancel";
  }

  public class UsernameEmptyTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter a username";
  }

  public class PasswordEmptyTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter a password";
  }

  public class FirstNameEmptyTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter a first name";
  }

  public class LastNameEmptyTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Please enter a last name";
  }

  public class NameOfRecipientTranslatable : Translatable
  {
    protected override string GetDefaultTransalationBasisText() => "Username of recipient";
  }

  public class ErrorOccurredTranslatable : Translatable
  {
    public ErrorOccurredTranslatable(string error) : base(error) { }
    protected override string GetDefaultTransalationBasisText() => "An error occurred: {0}";
  }
}
