import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ArticleGrid } from './ArticleGrid';

export default function pageInit() {
    initFullHeightGridPage(new ArticleGrid($('#GridDiv')).element);
}