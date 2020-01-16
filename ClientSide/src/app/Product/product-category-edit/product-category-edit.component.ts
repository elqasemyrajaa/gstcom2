import { Component, OnInit, Input } from '@angular/core';
import { ProductCategory } from '../product-category';
import { NgForm } from '@angular/forms';
import { ProductCategoryService } from '../product-category.service';

@Component({
  selector: 'app-product-category-edit',
  templateUrl: './product-category-edit.component.html',
  styleUrls: ['./product-category-edit.component.css']
})
export class ProductCategoryEditComponent implements OnInit {

  constructor(private service:ProductCategoryService) { }
 /***********************Variable******************************** */
 @Input() IsNew: boolean = true;
 dataavailbale:boolean=false;
 tempdate:ProductCategory;
 objlist:ProductCategory[];
 objtempemp:ProductCategory;
 @Input() objemp: ProductCategory = new ProductCategory();
 /********************Get Data()************************************* */
LoadData(){
 this.service.getProduct().subscribe((tempdate) => {
   this.objlist = tempdate;
     console.log(this.objlist);
     if (this.objlist.length > 0) {
       this.dataavailbale = true;
     }
     else {
       this.dataavailbale = false;
     }
   }
   )
     , err => {
       console.log(err);
     }
}
/*************************Add / Edit ************************************************ */
 /*************************Add / Edit ************************************************ */
 EditMainObject(regForm: NgForm) {
  /************************Add Code******************** */
  if(!this.IsNew){      
    this.objemp = regForm.value;
    console.log("modified",this.objemp);
    this.service.EditProductCategory(this.objemp).subscribe(res => {
      alert("product category  modified successfully");
    });
  }
  /********************Edit Code******************************** */
  else{
    this.objtempemp=new ProductCategory();      
    this.objtempemp.name=regForm.value.name;
    this.objtempemp.remarque=regForm.value.remarque;    
    this.service.AddProductCategory(this.objtempemp).subscribe(res=>{
      alert("product Added successfully");

    })
  }
}

  ngOnInit() {
  }
   
}
