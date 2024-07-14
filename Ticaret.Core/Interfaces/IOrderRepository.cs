using System;
using System.Collections.Generic;
using Ticaret.Core.Entities;

namespace Ticaret.Core.Interfaces
{
    public interface IOrderRepository
    {
        // Tüm siparişleri almak için metod
        IEnumerable<Order> GetAll();

        // Belirli bir siparişi ID'ye göre almak için metod
        Order GetById(int id);

        // Yeni bir sipariş eklemek için metod
        void Add(Order order);

        // Var olan bir siparişi güncellemek için metod
        void Update(Order order);

        // Bir siparişi ID'ye göre silmek için metod
        void Delete(int id);
    }
}
