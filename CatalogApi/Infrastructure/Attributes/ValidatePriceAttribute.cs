namespace CatalogApi.Infrastructure.Attributes
{
    public class ValidatePriceAttribute : ValidationAttribute
    {
        public ValidatePriceAttribute()
        {
            const string defaultErrorMessage = "Article price is erroneous";
            ErrorMessage ??= defaultErrorMessage;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var model = validationContext.ObjectInstance as Article;
            if (model is not null)
            {
                if (model.PriceSell < 0m || model.PriceBuy < 0m)
                {
                    return new ValidationResult("Prices must be positive values.");
                }

                if (model.PriceSell < model.PriceBuy)
                {
                    return new ValidationResult("Buy price must be less than Sell price.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
