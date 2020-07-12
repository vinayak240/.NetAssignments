import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
// import { NgForm } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './demo/demo.component';
import { EmployeesComponent } from './components/employees/employees.component';

@NgModule({
  declarations: [AppComponent, DemoComponent, EmployeesComponent],
  imports: [BrowserModule, AppRoutingModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
