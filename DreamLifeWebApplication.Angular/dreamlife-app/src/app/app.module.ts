import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';




import { AppMaterialModule } from './app-material/app-material.module';
import { DropdownMenuComponent } from './dropdown-menu/dropdown-menu.component';
import { RoutingModule } from 'src/app.router';
import { AppComponent } from './app.component';
import { TripsModule } from './trips/trips.module';
import { CadastroCidadeComponent } from './cadastro-cidade/cadastro-cidade.component';
import { CadastroHotelComponent } from './cadastro-hotel/cadastro-hotel.component';
import { VisualizarPaginaComponent } from './visualizar-pagina/visualizar-pagina.component';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbRating, NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    DropdownMenuComponent,
    CadastroCidadeComponent,
    CadastroHotelComponent,
    VisualizarPaginaComponent
  ],
  entryComponents: [],
  imports: [
    BrowserModule,
    TripsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppMaterialModule,
    RoutingModule,
    CommonModule,
    FormsModule,
    NgbModule,
    ReactiveFormsModule  
  ],
  exports: [
    AppComponent
  ],  
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
