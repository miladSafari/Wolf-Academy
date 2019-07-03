import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CourseCategoryListComponent } from './course-categories/course-category-list/course-category-list.component';
import { CourseCategoryComponent } from './course-categories/course-category/course-category.component';
import { RouterModule, Routes } from '@angular/router';

// import { FormsModule } from '@angular/forms';
// import { HttpClientModule } from '@angular/common/http';

// import { AppComponent } from './app.component';
// import { ItemDirective } from './item.directive';
const appRoutes: Routes = [
    { path: 'course-category-list', component: CourseCategoryListComponent },
    { path: 'course-category', component: CourseCategoryComponent },
  ];

// @NgModule decorator with its metadata
@NgModule({
    imports:       [ BrowserModule ,
    RouterModule.forRoot(appRoutes)
    ],
    providers:     [  ],
    declarations:  [
        CourseCategoryListComponent,
        CourseCategoryComponent
     ],
    exports:       [ ],
    bootstrap:     [  ]
})
export class AcademyModule { }
