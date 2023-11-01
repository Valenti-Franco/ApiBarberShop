//namespace TpiBarberShop.Models.Request
//{
//    public class CreatePlanRequest
//    {



//        var trialBillingCycle = new BillingCycle()
//        {
//            frequency = new Frequency()
//            {
//                interval_unit = "MONTH",
//                interval_count = 1,
//            },
//            tenure_type = "TRIAL",
//            sequence = 1,
//            total_cycles = 1,
//            pricing_scheme = new PricingScheme()
//            {
//                fixed_price = new FixedPrice()
//                {
//                    currency_code = "USD",
//                    value = "10.00"
//                }
//            }

//        };
//        var regularBillingCycle = new BillingCycle()
//        {

//            frequency = new Frequency()
//            {
//                interval_unit = "MONTH",
//                interval_count = 1,
//            },
//            tenure_type = "REGULAR",
//            sequence = 2,
//            total_cycles = 0,
//            pricing_scheme = new PricingScheme()
//            {
//                fixed_price = new FixedPrice()
//                {
//                    currency_code = "USD",
//                    value = "100.00"
//                }
//            }
//        };

//        var createPlanRequest = new CreatePlanRequest()
//        {
//            product_id = "1670568338", //Product Id
//            name = "Technical Voice Plan",
//            description = "Technical Voice Plan",
//            status = "ACTIVE",
//            billing_cycles = new List<BillingCycle>()
//                            {
//                                trialBillingCycle,
//                                regularBillingCycle
//                            },
//            payment_preferences = new PaymentPreferences()
//            {
//                auto_bill_outstanding = true,
//                setup_fee = new SetupFee()
//                {
//                    currency_code = "USD",
//                    value = "0"
//                },
//                setup_fee_failure_action = "CONTINUE",
//                payment_failure_threshold = 3
//            }

//        };
//    }
