import { Component, OnInit } from '@angular/core';
import { OrderService } from '../order.service';
import { Order } from 'src/app/shared/models/order';
import { ActivatedRoute } from '@angular/router';
import { BreadcrumbService } from 'xng-breadcrumb';

@Component({
  selector: 'app-order-detailed',
  templateUrl: './order-detailed.component.html',
  styleUrls: ['./order-detailed.component.scss']
})
export class OrderDetailedComponent implements OnInit{
  order?: Order

  constructor(private orderService: OrderService, private activatedRoute: ActivatedRoute, private bcService: BreadcrumbService) {}

  ngOnInit(): void {
    this.getOrder();
  }

  getOrder() {
    const id = this.activatedRoute.snapshot.paramMap.get('id')
    if (id) {
      this.orderService.getOrderById(+id).subscribe({
        next: order => {
          this.order = order
          this.bcService.set('@OrderDetailed', `Order# ${order.id} - ${order.status}`)
        }
      })
    }
  }
}
