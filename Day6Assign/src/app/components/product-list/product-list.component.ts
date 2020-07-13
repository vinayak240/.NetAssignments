import { Component, OnInit } from '@angular/core';
import Product from '../../models/Product';
@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  prodList: Product[];
  constructor() {
    this.prodList = JSON.parse(localStorage.getItem('prod_list')) || [];
  }

  ngOnInit(): void {}
}
