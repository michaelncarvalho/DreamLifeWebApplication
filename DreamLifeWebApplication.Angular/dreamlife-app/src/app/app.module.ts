import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';




import { AppMaterialModule } from './app-material/app-material.module';
import { DescricaoHotelComponent } from './descricao-hotel/descricao-hotel.component';
import { DropdownMenuComponent } from './dropdown-menu/dropdown-menu.component';
import { RoutingModule } from 'src/app.router';
import { AppComponent } from './app.component';
import { TripsModule } from './trips/trips.module';
import { ModalDescricaoComponent } from './modal-descricao/modal-descricao.component';
import { ModalDescricaoModule } from './modal-descricao/modal-descricao.module';

@NgModule({
  declarations: [
    AppComponent,
    DescricaoHotelComponent,
    DropdownMenuComponent,
    DescricaoHotelComponent
  ],
  entryComponents: [ModalDescricaoComponent],
  imports: [
    BrowserModule,
    TripsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppMaterialModule,
    RoutingModule,
    ModalDescricaoModule
  ],
  
  providers: [],
  bootstrap: [AppComponent, DropdownMenuComponent]
})

export class AppModule { }
