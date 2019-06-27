import { Component, ViewChild } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatTab, MatSort } from '@angular/material';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  displayedColumns;
  dataSource: MatTableDataSource<any>;
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  constructor(private _http: HttpClient ) {

  }


  ngOnInit() {
    this.displayedColumns = [];
    // this._http.get<any>().subscribe(data => {
    //   console.log(data);
    //   this.dataSource = new MatTableDataSource<any>(data);
    //   this.dataSource.paginator = this.paginator;
    //   this.dataSource.sort = this.sort;
    // });
  }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // MatTableDataSource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }

}
