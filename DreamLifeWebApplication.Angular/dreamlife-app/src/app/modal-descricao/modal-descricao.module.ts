import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { ModalDescricaoComponent } from './modal-descricao.component';



@NgModule({
  imports: [BrowserModule, NgbModule],
  declarations: [ModalDescricaoComponent],
  exports: [ModalDescricaoComponent],
  bootstrap: [ModalDescricaoComponent]
})
export class ModalDescricaoModule {}
