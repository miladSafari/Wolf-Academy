import { Component } from '@angular/core';
import { CourseCategory } from '../shared/course-category.model';
import { CourseCategoryService } from '../shared/course-category.service';

@Component({
    selector: 'course-category-list',
    templateUrl: './course-category-list.Component.html'
})
export class CourseCategoryListComponent {
    private courseCategories: Array<CourseCategory>;
    constructor(private service: CourseCategoryService) {
        // this.courseCategories = service.getAll();
        service.getAll().subscribe((data: Array<CourseCategory>) => {
            this.courseCategories = data;
        });
    }
}
