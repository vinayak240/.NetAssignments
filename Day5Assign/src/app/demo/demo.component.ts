import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  greet="The Angular app welcomes you..."
  constructor() { }

  ngOnInit(): void {
  }

}
