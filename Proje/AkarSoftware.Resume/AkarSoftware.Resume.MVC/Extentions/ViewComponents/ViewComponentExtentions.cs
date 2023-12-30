using AkarSoftware.Resume.Core.Utilities.Results.BaseResults;
using AkarSoftware.Resume.Core.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NToastNotify;

namespace AkarSoftware.Resume.MVC.Extentions.ViewComponents
{
	public static class ViewComponentExtentions
	{
		public static IViewComponentResult ReturnViewForComponent<T>(this ViewComponent component, IDataResult<T> Data, string ViewName, string componentName)
		{
			if (Data.Status == ResultStatus.Success)
				return component.View(ViewName, Data.Data);

			var serviceProvider = component.HttpContext.RequestServices;
			var toastNotificationService = serviceProvider.GetRequiredService<IToastNotification>();
			toastNotificationService.AddErrorToastMessage(componentName + " komponenti için bir veri bulunamadı ");
			return component.View(Data.Data);

		}
	}
}
