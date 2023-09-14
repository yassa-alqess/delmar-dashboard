import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoryGrid } from './CategoryGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoryGrid($('#GridDiv')).element);
}