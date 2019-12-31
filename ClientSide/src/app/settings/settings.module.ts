import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; 
import { VatComponent } from './vat/vat.component';
import { VatEditComponent } from './vat-edit/vat-edit.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AgGridModule } from 'ag-grid-angular';
import { VatService } from './vat-service';
import { VatResolverService } from './vat-resolver-service';
import { StatutComponent} from './statut/statut.component';
import { StatutEditComponent } from './statut-edit/statut-edit.component';
import {MatButtonModule} from '@angular/material/button';
import { MatInputModule, MatFormFieldModule, MatLabel } from '@angular/material';


const MaterialComponents=[
  MatButtonModule,
  MatInputModule,
  MatFormFieldModule,
]

@NgModule({
  declarations: [
    VatComponent,
    VatEditComponent,
    StatutComponent, 
    StatutEditComponent,
  ],
  imports: [
    MaterialComponents,
    CommonModule ,
    SettingsRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    AgGridModule.withComponents([
    ]),
  ],
 
  providers: [
    VatService,
    VatResolverService,
    MaterialComponents
  ],
  
})
export class SettingsModule { }
