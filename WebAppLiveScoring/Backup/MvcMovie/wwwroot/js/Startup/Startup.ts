import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { MainModuleLibrary } from '../Angular/Module/MainModuleLibrary';
const platform = platformBrowserDynamic();
platform.bootstrapModule(MainModuleLibrary);