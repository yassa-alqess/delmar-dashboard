import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CommentsGrid } from './CommentsGrid';

export default function pageInit() {
    initFullHeightGridPage(new CommentsGrid($('#GridDiv')).element);
}