import { Component, OnInit, Input } from '@angular/core';
import { MaterialModule } from '../Material/material.module';
import { GridApi, ColumnApi } from 'ag-grid-community';
import { Paiement } from 'src/Models/paiement';
import { PaiementService } from '../paiement.service';

export{
  MaterialModule
}

@Component({
  selector: 'app-paiement',
  templateUrl: './paiement.component.html',
  styleUrls: ['./paiement.component.css']
})
export class PaiementComponent implements OnInit {

  constructor(private serv1:PaiementService) { }
  /*********************Variable ag-grid***************************** */
  private api: GridApi;
  private columnApi: ColumnApi;
  private rowSelection;
  private SelectedClient:Paiement;
  IsRowSelected: boolean = false;
  IsMultiple: boolean = false;
  IsNew: boolean;
  private sortingOrder;
  /******************Fill ag grid ******************************** */
  onGridReady(params): void {
    this.api = params.api;
    this.columnApi = params.columnApi;
    this.api.sizeColumnsToFit();
  }
  /********************** Create colmun in ag grid*********************************** */
  columnDefs=[
    {
      headerName:"ID",
      field:"ID",
      checkboxSelection: true
    },
    {
      headerName:"ContractID",
      field:"ContractID",
      sortingOrder:["asc","desc"],
 
    },
    {
      headerName:"ClientID",
      field:"ClientID",

    },
    {
      headerName:"NumReçus",
      field:"NumReçus",

    },
    {
      headerName:"Date",
      field:"Date",
  
    },
    {
      headerName:"BankID",
      field:"BankID",

    },
    {
      headerName:"price",
      field:"price",
    },
  ]
  /***********************Variables*************************** */
  objtempemp:Paiement;
  @Input() objemp: Paiement = new Paiement();
  dataavailbale:boolean=false;
  tempdate:Paiement;
  objlist:Paiement[];
  /****************************Refresh data()************************************** */
  // RefreshData() {
  //   this.LoadData();
  // }
  /***************************get Data()********************************** */
  paimentObj:Paiement;
  paimentList:Paiement[];
  loadData(){
    this.serv1.getPayments().subscribe((paimentObj)=>{
      this.paimentList=paimentObj;
      if(this.paimentList.length > 0){
          console.log("data existe");
      }else{
        console.log("date est vide");
      }
    })
  }
  // LoadData(){
  //   this.serv1.getPayments().subscribe((tempdate) => {
  //     this.objlist = tempdate;
  //       console.log(this.objlist);
  //       if (this.objlist.length > 0) {
  //         this.dataavailbale = true;
  //         console.log("data is got");
  //       }
  //       else {
  //         this.dataavailbale = false;
  //         console.log("data is vide");
  //       }
  //     }
  //     )
  //     , err => {
  //         console.log(err);
  //       }
  // }


  ngOnInit() {
    this.loadData();
  }

}
