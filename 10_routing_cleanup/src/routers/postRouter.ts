import { Router } from 'express';
import * as postController from '../controllers/posts.ts';

const router = Router();

// POSTS routes
router.get('/', postController.getPosts);
router.post('/', postController.createPost);
router.get('/:id', postController.getPostById);
router.put('/:id', postController.updatePost);
router.delete('/:id', postController.deletePost);

export default router;
