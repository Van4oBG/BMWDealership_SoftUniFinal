using BMWDealership_SoftUniFinal.Models;
using Microsoft.AspNetCore.Mvc;

public class CatalogController : Controller
{
    private static List<CatalogCars> items = new List<CatalogCars>
    {
        new CatalogCars { Id = 1, Title = "BMW M3 Competition", Price = "66,241", Description = "BMW M3 Competition 2025 е високопроизводителен седан, отличаващ се с мощен двигател, усъвършенствани технологии и изискана естетика. Ключовите актуализации включват увеличение с 20 к.с. за модела M3 Competition xDrive, с което мощността му достига 523 к.с., и освежен екстериор с нови фарове и дизайн на джантите. В интериора, инфоразвлекателната система iDrive 8.5, актуализираната облицовка на арматурното табло и преработеният волан подобряват шофирането.", Year = 2025, ImageUrl = "/images/bmwm3comp.jpg", Horsepower = 523, Transmission = "8-Скоростна, Автоматична" },
        new CatalogCars { Id = 2, Title = "BMW M4 G82 Competition", Price = "73,387", Description = "BMW M4 Competition (G82) 2025 е високопроизводително купе, което разполага с 3,0-литров редови 6-цилиндров двигател с различна мощност в зависимост от конфигурацията. Моделът Competition може да се похвали с 523 конски сили и 640 Nm въртящ момент във версията xDrive (задвижване на всички колела) според MotorTrend. Той се предлага с 8-степенна автоматична скоростна кутия, а показателите за производителност като ускорение и максимална скорост са впечатляващи, като ускорението от 0 до 100 км/ч е постижимо само за 3,5 секунди с M xDrive. M4 Competition предлага и редица естетически и технологични подобрения, включително нови фарове, лазерни задни светлини и ревизиран интериор с 12,3-инчов арматурно табло и 14,9-инчов сензорен екран.", Year = 2025, ImageUrl = "/images/bmwm4comp.jpg", Horsepower = 523, Transmission = "8-скоростна, Автоматична" },
        new CatalogCars { Id = 3, Title = "BMW M5 Competition", Price = "102,570", Description = "BMW M5 2025 е високопроизводителен plug-in хибриден седан, оборудван с V8 двигател с два турбокомпресора и електрически мотор, осигуряващи комбинирана мощност от 717 конски сили. Той може да се похвали с 8-степенна автоматична скоростна кутия, стандартно задвижване на всички колела с режим на задвижване на задните колела и адаптивни амортисьори. M5 предлага и различни режими на шофиране, включително функция boost за незабавно ускорение.", Year = 2025, ImageUrl = "/images/bmwm5comp.jpg", Horsepower = 717, Transmission = "8-скоростна, Автоматична" }
    };

    public IActionResult Index()
    {
        return View(items);
    }

    public IActionResult Details(int id)
    {
        var item = items.FirstOrDefault(x => x.Id == id);
        if (item == null)
        {
            return NotFound();
        }

        return View(item);
    }
}
