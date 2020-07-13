import { Component, OnInit } from '@angular/core';
import Product from '../../models/Product';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {
  product: Product;
  constructor(private router: Router) {
    if (!localStorage.getItem('prod_list')) {
      localStorage.setItem('prod_list', JSON.stringify([]));
    }
    this.product = {
      pid: '',
      pname: '',
      price: null,
      stock: null
    };
  }

  ngOnInit(): void {}

  onSubmit(f: NgForm) {
    if (f.valid) {
      let obj = { ...f.value };
      console.log('Product : ', obj);

      let arr = JSON.parse(localStorage.getItem('prod_list'));
      arr.push(obj);
      localStorage.setItem('prod_list', JSON.stringify(arr));
      this.router.navigateByUrl('product-list');

      this.product = {
        pid: '',
        pname: '',
        price: null,
        stock: null
      };
    } else {
      alert('Cannot Submit');
    }
  }
}
