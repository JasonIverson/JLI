﻿namespace JLI.Framework.Core {

    /// <summary>
    /// Represents the result of some action being taken
    /// </summary>
    public class Result {

        #region Constants

        private const string SUCCESS_MESSAGE = "Success!";

        #endregion Constants

        #region Constructor(s)

        internal Result(bool successful, string? message, Exception? exception) {
            this.Successful = successful;
            this.Message = message;
            this.Exception = exception;
        }

        #endregion Constructor(s)

        #region Non-parameterized static accessors

        public static Result SuccessResult() {
            return new Result(true, SUCCESS_MESSAGE, null);
        }

        public static Result SuccessResult(string message) {
            return new Result(true, message, null);
        }

        public static Result ErrorResult(string message) {
            return new Result(false, message, null);
        }

        public static Result ErrorResult(string message, Exception exception) {
            return new Result(false, message, exception);
        }

        #endregion Non-parameterized static accessors

        #region Parameterized static accessors

        public static Result<TValue> SuccessResult<TValue>(TValue returnValue) {
            return new Result<TValue>(true, SUCCESS_MESSAGE, null, returnValue);
        }

        public static Result<TValue> SuccessResult<TValue>(string message, TValue returnValue) {
            return new Result<TValue>(true, message, null, returnValue);
        }

        public static Result<TValue> ErrorResult<TValue>(string message) {
            return new Result<TValue>(false, message, null, default);
        }

        public static Result<TValue> ErrorResult<TValue>(string message, Exception exception) {
            return new Result<TValue>(false, message, exception, default);
        }

        #endregion Parameterized static accessors

        #region Properties

        public bool Successful { get; private set; }

        public string? Message { get; private set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Exception? Exception { get; private set; }

        #endregion Properties

        #region Overrides

        public override string? ToString() {
            string? message = this.Message;
            if (!this.Successful)
                message = $"Error:  {message}";
            if (this.Exception != null)
                message = $"{message}{Environment.NewLine}{Environment.NewLine}{this.Exception.Traverse()}";
            return message;
        }

        #endregion Overrides

    }
}
