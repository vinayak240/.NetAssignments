import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
// import { NgForm } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './components/product-list/product-list.component';
import { ProductAddComponent } from './components/product-add/product-add.component';

@NgModule({
  declarations: [AppComponent, ProductListComponent, ProductAddComponent],
  imports: [BrowserModule, AppRoutingModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
