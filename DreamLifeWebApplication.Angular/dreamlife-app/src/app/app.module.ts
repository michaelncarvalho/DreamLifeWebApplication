import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';




import { AppMaterialModule } from './app-material/app-material.module';
import { DropdownMenuComponent } from './dropdown-menu/dropdown-menu.component';
import { RoutingModule } from 'src/app.router';
import { AppComponent } from './app.component';
import { TripsModule } from './trips/trips.module';
import { ModalDescricaoComponent } from './modal-descricao/modal-descricao.component';
import { ModalDescricaoModule } from './modal-descricao/modal-descricao.module';
import { CadastroCidadeComponent } from './cadastro-cidade/cadastro-cidade.component';
import { CadastroHotelComponent } from './cadastro-hotel/cadastro-hotel.component';
import { VisualizarPaginaComponent } from './visualizar-pagina/visualizar-pagina.component';

@NgModule({
  declarations: [
    AppComponent,
    DropdownMenuComponent,
    CadastroCidadeComponent,
    CadastroHotelComponent,
    VisualizarPaginaComponent
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
  exports: [
    AppComponent
  ],  
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
