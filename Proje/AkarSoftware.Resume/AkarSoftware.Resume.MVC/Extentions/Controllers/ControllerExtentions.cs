using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using AkarSoftware.Resume.Dtos.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace AkarSoftware.Resume.MVC.Extentions.Controllers
{
    public static class ControllerExtentions
    {
        public static IActionResult CostumeRedirectToAction<T>(this Controller controller, Core.Utilities.Results.BaseResults.IResult result, T DtoDatas, RedirectToActionResult redirectParameter, string Anliklink)
        {
            var toastNotificationService = controller.HttpContext.RequestServices.GetRequiredService<IToastNotification>();

            if (result.Status == ResultStatus.ValidationError)
            {
                foreach (var item in result.ValidationErrors)
                {
                    controller.ModelState.AddModelError(item.PropertyName, item.ErrorDescription);
                }
                if (!string.IsNullOrEmpty(result.Messages))
                {
                    toastNotificationService.AddErrorToastMessage(result.Messages);
                }

                return controller.View(Anliklink, DtoDatas);
            }
            else if (result.Status == ResultStatus.Error || result.Status == ResultStatus.NotFound)
            {
                if (!string.IsNullOrEmpty(result.Messages))
                {
                    toastNotificationService.AddErrorToastMessage(result.Messages);
                }
                return controller.View(Anliklink, DtoDatas);
            }
            else
            {
                if (typeof(T) == typeof(LoginUserDto))
                {
                    var logindto = DtoDatas as LoginUserDto;
                    if (!string.IsNullOrEmpty(logindto.ReturnUrl))
                    {
                        if (!string.IsNullOrEmpty(result.Messages))
                        {
                            toastNotificationService.AddErrorToastMessage();
                        }
                        return controller.RedirectToAction(logindto.ReturnUrl);
                    }
                }

                return redirectParameter;
            }


        }
    }
}
