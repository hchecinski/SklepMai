
using FluentValidation.Results;

namespace SklepMai.Core
{
    public abstract class BaseResponse
    { 
        public bool IsSuccess { get; protected set; } = true;
        public string Message { get; protected set; } = string.Empty;
        public List<string> ValidationErrors { get; protected set; } = new List<string>();

        public BaseResponse()
        {
            
        }

        public BaseResponse(string message)
        {
            Message = message;
        }

        public BaseResponse(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public BaseResponse(List<string> validationErrors)
        {
            ValidationErrors = validationErrors;
            IsSuccess = false;
        }

        public BaseResponse(ValidationResult validationResult)
        {
            foreach (var item in validationResult.Errors)
            {
                ValidationErrors.Add(item.ErrorMessage);
            }
            
            IsSuccess = false;
        }
    }
}