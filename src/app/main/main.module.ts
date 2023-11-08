import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormularioComponent } from './components/formulario/formulario.component';
import { MainComponent } from './page/main-page.component';



@NgModule({
  declarations: [
    FormularioComponent,
    MainComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    MainComponent
  ]
})
export class MainModule { }
