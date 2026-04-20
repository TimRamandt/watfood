import { Routes } from '@angular/router';
import { HomePage } from './app/pages/index.page'
import { RecipePage } from './app/pages/recipes.page';

export const routes: Routes = [
  {
    path: '',
    component: HomePage,
  },
  {
    path: 'recipes',
    component: RecipePage,
  },
];