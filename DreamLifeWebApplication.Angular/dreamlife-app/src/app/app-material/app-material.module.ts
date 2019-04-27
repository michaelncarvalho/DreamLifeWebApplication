import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatMenuModule} from '@angular/material/menu';
import {MatIconModule} from '@angular/material/icon';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    MatToolbarModule, 
    MatMenuModule,
    MatIconModule
  ],
  declarations: []
})
export class AppMaterialModule { }
