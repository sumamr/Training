import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypesComponent } from './datatypes/datatypes.component';
import { TestComponent } from './test/test.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { CustomerComponent } from './components/customer/customer.component';
import { DatabindingComponent } from './components/databinding/databinding.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SimpleinterestComponent } from './components/simpleinterest/simpleinterest.component';
import { SimplecalculatorComponent } from './components/simplecalculator/simplecalculator.component';
import { SwitchdemoComponent } from './components/switchdemo/switchdemo.component';
import { SumaComponent } from './suma/suma.component';
import { StyledemoComponent } from './components/styledemo/styledemo.component';
import { ClassdemoComponent } from './components/classdemo/classdemo.component';
import { TemplateformdemoComponent } from './components/templateformdemo/templateformdemo.component';
import { EmployeetemplateformdemoComponent } from './components/employeetemplateformdemo/employeetemplateformdemo.component';
import { CoronaComponent } from './components/corona/corona.component';
import {HttpClientModule} from '@angular/common/http';
import { TodosComponent } from './components/todos/todos.component';
import { PostsComponent } from './components/posts/posts.component';
import { ParentComponent } from './components/parent/parent.component';
import { ChildComponent } from './components/child/child.component';
import { CompanyComponent } from './components/company/company.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { ExponentialStrengthPipe } from './pipes/exponential-strength.pipe';
import { PipesComponent } from './components/pipes/pipes.component';
import { ReactiveFormComponent } from './components/reactive-form/reactive-form.component';



@NgModule({
  declarations: [
    AppComponent,
    DatatypesComponent,
    TestComponent,
    EmployeeComponent,
    CustomerComponent,
    DatabindingComponent,
    SimpleinterestComponent,
    SimplecalculatorComponent,
    SwitchdemoComponent,
    SumaComponent,
    StyledemoComponent,
    ClassdemoComponent,
    TemplateformdemoComponent,
    EmployeetemplateformdemoComponent,
    CoronaComponent,
    TodosComponent,
    PostsComponent,
    ParentComponent,
    ChildComponent,
    CompanyComponent,
    CompaniesComponent,
    ExponentialStrengthPipe,
    PipesComponent,
    ReactiveFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
