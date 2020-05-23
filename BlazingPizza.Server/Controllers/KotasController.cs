using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Server
{
    [Route("kotas")]
    [ApiController]
    public class KotasController : Controller
    {
        private readonly KotaStoreContext _db;

        public KotasController(KotaStoreContext db)
        {
            _db = db;
        }
    }
}
