import { Component, Injector, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { CategoriesServiceProxy, InputDto, PeopleDto } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
})
export class SearchComponent extends AppComponentBase implements OnInit{

  constructor(
    injector: Injector, 
    public categoryAppService: CategoriesServiceProxy,
  ) {
    super(injector);
  }

  records: PeopleDto[] = [];
  jokesRecords: string[] = [];

  filterText = "";
  isProcessing = false;

  ngOnInit(): void {
  }

  getData(): void{
    var input = new InputDto();
    input.filterText = this.filterText;
    this.isProcessing = true;

    this.categoryAppService.search(input).subscribe((result) => {
      this.records = result.people;
      this.jokesRecords = result.jokes;
      this.isProcessing = false;
    });
  }

}
