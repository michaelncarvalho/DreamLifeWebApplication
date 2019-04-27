import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { EditComponent } from './edit.component';
import { CommonModule } from '@angular/common';


@NgModule({
  declarations: [
    EditComponent,    
  ],
  imports: [
    BrowserModule,
    CommonModule
  ],
  providers: [],
  bootstrap: [EditComponent]
})
export class EditModule { }