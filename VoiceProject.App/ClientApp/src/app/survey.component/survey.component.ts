import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-survey',
  templateUrl: './survey.component.html'
})
export class SurveyComponent {
  public Survey: Survey;
  
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<APIRequestResult>(baseUrl + 'api/survey/get/1').subscribe(result => {      
      this.Survey = result.data;
    }, error => console.error(error));
  }
}

