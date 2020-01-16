import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import{MaterialModule} from '../Material/material.module';
import { GridApi, ColumnApi } from 'ag-grid-community';
import { ProductCategory } from '../product-category';
import { ProductCategoryService } from '../product-category.service';
import { HttpClient } from '@angular/common/http';
import { ProductComponent } from 'src/app/stock/product/product.component';
import { ProductCategoryEditComponent } from '../product-category-edit/product-category-edit.component';
export{
  MaterialModule
}

@Component({
  selector: 'app-product-category',
  templateUrl: './product-category.component.html',
  styleUrls: ['./product-category.component.css']
})

export class ProductCategoryComponent implements OnInit {

  constructor(private service:ProductCategoryService,private http: HttpClient) {
    this.rowSelection = "multiple";
   }

  
   @Output() nameEvent = new EventEmitter<string>();
   @ViewChild('editproduct', { static: false, }) editcomponent:ProductCategoryEditComponent
   /**********************edit (when you click the information will transform to other component)******************************** */
  edit(){
    if(this.IsRowSelected){
      this.SelectedClient = this.api.getSelectedRows()[0];
      this.editcomponent.IsNew = false;
      this.editcomponent.objemp=this.SelectedClient;
    }
  }
    /***********************test if row is selected or not******************************** */
    tes:string;
    StObjet:ProductCategory[];
    onSelectionChanged(event) {
      if (this.api.getSelectedRows().length == 0) {
        this.IsRowSelected = false;
      } else {
        this.IsRowSelected = true;
        this.StObjet=this.api.getSelectedRows();
      }
      if (this.api.getSelectedRows().length != 1) {
        this.IsMultiple = true;
      } else {
        this.IsMultiple = false;
      }
    }
  /*********************Variable ag-grid***************************** */
  private api: GridApi;
  private columnApi: ColumnApi;
  private rowSelection;
  private SelectedClient:ProductCategory;
  IsRowSelected: boolean = false;
  IsMultiple: boolean = false;
  IsNew: boolean;
  private sortingOrder;
  /******************Fill ag grid ******************************** */
  onGridReady(params): void {
    this.api = params.api;
    this.columnApi = params.columnApi;
    this.api.sizeColumnsToFit();
    this.loadData();
  }
  /********************** Create colmun in ag grid*********************************** */
  columnDefs=[
    {
      headerName:"ID",
      field:"id",
      checkboxSelection: true
    },
    {
      headerName:"Name",
      field:"name",
      sortingOrder:["asc","desc"],
 
    },
    {
      headerName:"Remarque",
      field:"remarque",
    },
  ]
  list:ProductCategory[];
  res:ProductCategory;

  loadData(){
    return this.service.getProduct().subscribe(res=>{
      this.list=res;
      console.log("data",this.list);
    })
  }
  /********************Delete()***************************** */
  deleteProduct(id){
    this.service.delete(id).subscribe(res=>{
      alert('suppression bien fait');
    })
  }
  ngOnInit() {
    this.loadData();
  }

}
