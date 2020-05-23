using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }

        public Kota ConfiguringKota { get; private set; }

        public Order Order { get; private set; } = new Order();


        public void ShowConfigureKotaDialog(KotaSpecial special)
        {
            ConfiguringKota = new Kota()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Kota.DefaultSize,
                Toppings = new List<KotaTopping>(),
            };

            ShowingConfigureDialog = true;
        }

        public void CancelConfigureKotaDialog()
        {
            ConfiguringKota = null;

            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigureKotaDialog()
        {
            Order.Kotas.Add(ConfiguringKota);
            ConfiguringKota = null;

            ShowingConfigureDialog = false;
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        public void RemoveConfiguredKota(Kota pizza)
        {
            Order.Kotas.Remove(pizza);
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}
